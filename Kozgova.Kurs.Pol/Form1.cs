using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kozgova.Kurs.Pol
{
    public partial class Form1 : Form
    {
        double min0OutPol; // максимальное значение выживаемости (близость к ответу)

        double sredOutPol; // среднее значение выживаемости
        int numberGenOutPol; // число поколений
        int numberPopOutPol; // размер популяции
        int numberTurnOutPol; // размер турнира 
        double pcrossOutPol; // вероятность скрещивания
        double pmutationOutPol; // вероятность мутации
        int genNowOutPol; // текущее поколение
        double min0PolX1;
        double min0PolX2;

        const int lchrom = 2; // число генов
        const int maxpop = 500; // максимальный размер популяции
        public double[] maxmass;
        public double[] sredmass;
        public double[] maxmassX1;
        public double[] maxmassX2;
        public int[] masspok;
        public int[] gisvalue;

        public class individualOutPol //особь без пола
        {
            public double[] chrom { get; set; } = new double[lchrom];
            public double fitness { get; set; }  // коэффициент выживаемости (значение функции) 
            public individualOutPol()
            {
                for (int i = 0; i < lchrom; i++)
                {
                    chrom[i] = -1;
                }
                fitness = -1;
            }
        }

        // Создаем массивы для беcполового скрещивания
        individualOutPol[] oldpopOutPol = new individualOutPol[maxpop]; // массив для старого поколения полового скрещивания
        

        //основная функция Растригина f(x1, x2) = 20 + x1*x1 + x2*x2 − 10(cos 2πx1 + cos2πx2) 
        double objfunc(double x1, double x2)
        {
           return (20 + x1 * x1 + x2 * x2 - 10 * (Math.Cos(2 * Math.PI * x1) + Math.Cos(2 * Math.PI * x2)));
           
        }


        public Form1()
        {
            InitializeComponent();
        }

        public void initpopOutPol()
        {
            Random rnd = new Random();
            for (int i=0; i< numberPopOutPol; i++)
            {
                
                oldpopOutPol[i].chrom[0] = -1 + rnd.NextDouble()*2;                
                oldpopOutPol[i].chrom[1] = -1 + rnd.NextDouble()*2;
                oldpopOutPol[i].fitness = objfunc(oldpopOutPol[i].chrom[0], oldpopOutPol[i].chrom[1]);
            }
        }

        public void statisticsOutPol(individualOutPol[] pop, int variant)
        {
            min0OutPol = pop[0].fitness;
            min0PolX1 = pop[0].chrom[0];
            min0PolX2 = pop[0].chrom[1];
            sredOutPol = pop[0].fitness;
            for (int i=1; i < numberPopOutPol; i++)
            {
                sredOutPol += pop[i].fitness;
                if (pop[i].fitness < min0OutPol)
                {
                    min0OutPol = pop[i].fitness;
                    min0PolX1 = pop[i].chrom[0];
                    min0PolX2 = pop[i].chrom[1];
                }
            }
            sredOutPol = sredOutPol / numberPopOutPol;
            if (variant == 0)
            {
                chart1.Series[0].Points.AddXY(genNowOutPol, min0OutPol);
                chart1.Series[1].Points.AddXY(genNowOutPol, sredOutPol);
            }
            maxmass[genNowOutPol - 1] = min0OutPol;
            maxmassX1[genNowOutPol - 1] = min0PolX1;
            maxmassX2[genNowOutPol - 1] = min0PolX2;
            sredmass[genNowOutPol - 1] = sredOutPol;

        }


        public double mutation (double fit)
        {
            Random rnd = new Random();
            double p = rnd.NextDouble();
            if (p<pmutationOutPol)
            {
                fit = fit - rnd.NextDouble()/10; //0,1-0,05=0,05   0-0,05=-0,05
            }
            return fit;
        }

        public void crossoverOutPol()
        {
            double p;
            individualOutPol c1 = new individualOutPol();
            Random rnd = new Random();
            for (int i=0; i <= numberPopOutPol; i++)
            {
             
                p = rnd.NextDouble();
                if (p<pcrossOutPol)
                {
                    c1.chrom[0] = mutation(oldpopOutPol[i].chrom[0]);
                    c1.chrom[1] = mutation(oldpopOutPol[i].chrom[1]);
                    c1.fitness = objfunc(c1.chrom[0], c1.chrom[1]);
                }

                double maxIndFitness = oldpopOutPol[0].fitness;
                int maxIndIndex = 0;
                //ищем индекс самой неприспособленной особи на данный момент
                for (int j = 0; j < numberPopOutPol; j++)
                {
                    if (oldpopOutPol[j].fitness > maxIndFitness)
                    {
                        maxIndIndex = j;
                        maxIndFitness = oldpopOutPol[j].fitness;
                    }
                }
                //если ребенок более приспособленный, чем самая неприспособленная особь, заменяем эту особь ребенком
                if (c1.fitness < maxIndFitness)
                {
                    oldpopOutPol[maxIndIndex] = c1;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < maxpop; i++)
            {
                oldpopOutPol[i] = new individualOutPol();//старое поколение популяции
                
            }

            numberGenOutPol = (int)numOutGen.Value;
            numberPopOutPol = (int)numOutPop.Value;
            numberTurnOutPol = (int)numOutTurn.Value;
            pcrossOutPol = (double)numOutCross.Value;
            pmutationOutPol = (double)numOutMut.Value;
            maxmass = new double[numberGenOutPol];
            sredmass = new double[numberGenOutPol];

            initpopOutPol(); //создаем первое поколение популяции
           
            genNowOutPol = 1;
            statisticsOutPol(oldpopOutPol,0);

            do
            {
                genNowOutPol++;               
                crossoverOutPol();                
                statisticsOutPol(oldpopOutPol,0);                 

            } while (genNowOutPol < numberGenOutPol); // сколько раз было задано 

            double v = 10000;
            for (int i = 0; i < genNowOutPol - 1; i++)
            {
                if (maxmass[i] < v)
                {
                    v = maxmass[i];
                }
            }

            lbmin.Text = v.ToString();


        }

        private void btStartExp_Click(object sender, EventArgs e)
        {
            numberGenOutPol = (int)numOutGen.Value;
            numberPopOutPol = (int)numOutPop.Value;
            numberTurnOutPol = (int)numOutTurn.Value;
            pcrossOutPol = (double)numOutCross.Value;
            pmutationOutPol = (double)numOutMut.Value;
            masspok = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < maxpop; j++)
                {
                    oldpopOutPol[j] = new individualOutPol();//старое поколение популяции

                }

                maxmass = new double[numberGenOutPol];
                sredmass = new double[numberGenOutPol];

                initpopOutPol(); //создаем первое поколение популяции
                genNowOutPol = 1;
                maxmassX1 = new double[numberGenOutPol];
                maxmassX2 = new double[numberGenOutPol];
                statisticsOutPol(oldpopOutPol, 1);

                do
                {
                    genNowOutPol++;
                    crossoverOutPol();
                    statisticsOutPol(oldpopOutPol, 1);

                } while (genNowOutPol < numberGenOutPol); // сколько раз было задано 

                // Если искать минимальное найденное решение
                //double v = 10000;
                //int pokmin = 0;
                //for (int k = 0; k < genNowOutPol - 1; k++)
                //{
                //    if (maxmass[k] < v)
                //    {
                //        pokmin = k + 1;
                //        v = maxmass[k];
                //    }
                //}


                //Если искать первое решение, которое меньше okolo
                int pokmin = 0;
                double v = 10000;
                double okolo = 0.01;
                // ограничения зоны поиска минимума по Х
                double smaxX1 = 0.4;
                double sminX1 = -0.4;
                // ограничения зоны поиска минимума по У
                double smaxX2 = 0.4;
                double sminX2 = -0.4;
                for (int k = 0; k < genNowOutPol - 1; k++)
                {
                    if (maxmass[k] < okolo)
                    {
                        if (maxmass[k] < v && maxmassX1[k] < smaxX1 && maxmassX1[k] > sminX1 && maxmassX2[k] < smaxX2 && maxmassX1[k] > sminX2)
                        {
                            pokmin = k + 1;
                            break;
                        }
                        pokmin = k + 1;
                        v = maxmass[k];
                    }
                }
                
                masspok[i] = pokmin;

                
            }
                for (int i = 0; i < masspok.Length; i++)
                {
                    Console.WriteLine(masspok[i]);
                }

                gisvalue = new int[numberGenOutPol + 1];
                for (int i = 0; i < masspok.Length; i++)
                {
                    gisvalue[masspok[i]]++;
                }

                for (int i = 0; i < gisvalue.Length; i++)
                    chart2.Series[0].Points.AddXY(i, gisvalue[i]);
        }
    }
}
