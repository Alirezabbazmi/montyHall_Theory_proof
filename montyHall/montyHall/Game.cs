using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace montyHall
{
    class Game
    {
        private string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\montyhalldatabase";
        
        private string pathturn = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\montyhalldatabase\turnav.txt";
        private string pathavgwin = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\montyhalldatabase\avgav.txt";
        private string pathavglose = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\montyhalldatabase\avgavlose.txt";
        private string pathwinwhencheng = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\montyhalldatabase\winwhenchengavgav.txt";
        private string pathlosewhencheng = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\montyhalldatabase\avgavlosewhencheng.txt";
        private string pathwindontcheng = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\montyhalldatabase\winwhenchengavgav.txt";
        private string pathlosedontcheng = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\montyhalldatabase\avgavlosewhencheng.txt";
        private double  gameavgwinwhenselectCH , gameavgwinwithoutselectCH, gameavglosewhenselectCH, gameavglosewithoutselectCH ,gamewinWhenChengSelect, gameloseWhenChengSelect , gamewinWhendontCheng, gameloseWhendontCheng;
        private double gameturn ;
        private int pick; 
      
        private Random random = new Random();
        private void avg()
        {
            gameavgwinwhenselectCH = (gamewinWhenChengSelect / gameturn) * 100;
            gameavgwinwithoutselectCH = (gamewinWhendontCheng / gameturn) * 100;
            gameavglosewhenselectCH = (gameloseWhenChengSelect / gameturn) * 100;
            gameavglosewithoutselectCH = (gameloseWhendontCheng / gameturn) * 100;
        }
        private void avrageSetter()
        {
            File.WriteAllText(pathwinwhencheng, ""+gamewinWhenChengSelect+"");
            File.WriteAllText(pathlosewhencheng,""+gameloseWhendontCheng+"" );
            File.WriteAllText(pathwindontcheng, "" + gamewinWhendontCheng + "");
            File.WriteAllText(pathlosedontcheng, "" + gameloseWhendontCheng + "");
            File.WriteAllText(pathturn, ""+gameturn+"");
            File.WriteAllText(pathavgwin, ""+gameavgwinwhenselectCH+"");
            File.WriteAllText(pathavglose, "" + gameavgwinwithoutselectCH + "");
        }
        private void DatabaseCreator()
        {
            if (!File.Exists(pathwinwhencheng))
            {
                using (StreamWriter sw = File.CreateText(pathwinwhencheng))
                {
                    sw.WriteLine(""+0+"");

                }

            }
            if (!File.Exists(pathlosewhencheng))
            {
                using (StreamWriter sw = File.CreateText(pathlosewhencheng))
                {
                    sw.WriteLine("" + 0 + "");

                }
            }
            if (!File.Exists(pathwindontcheng))
            {
                using (StreamWriter sw = File.CreateText(pathwindontcheng))
                {
                    sw.WriteLine("" + 0 + "");

                }

            }
            if (!File.Exists(pathlosedontcheng))
            {
                using (StreamWriter sw = File.CreateText(pathlosedontcheng))
                {
                    sw.WriteLine("" + 0 + "");

                }
            }
            if (!File.Exists(pathturn))
            {

                using (StreamWriter sw = File.CreateText(pathturn))
                {
                    sw.WriteLine("" + 0 + "");

                }
            }
            if (!File.Exists(pathavgwin))
            {

                using (StreamWriter sw = File.CreateText(pathavgwin))
                {
                    sw.WriteLine("" + 0 + "");

                }
            }
            if (!File.Exists(pathavglose))
            {
                using (StreamWriter sw = File.CreateText(pathavglose))
                {
                    sw.WriteLine("" + 0 + "");

                }
            }
            if (!File.Exists(pathwinwhencheng))
            {

                using (StreamWriter sw = File.CreateText(pathwinwhencheng))
                {
                    sw.WriteLine("" + 0 + "");

                }
            }
            if (!File.Exists(pathlosewhencheng))
            {
                using (StreamWriter sw = File.CreateText(pathlosewhencheng))
                {
                    sw.WriteLine("" + 0 + "");

                }
            }
        }
        private void avragereader()
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                DatabaseCreator();
            }
            DatabaseCreator();
            if (File.ReadAllText(pathwindontcheng).Length == 0)
            {
                File.WriteAllText(pathwindontcheng, "" + 0 + "");
            }
            gamewinWhendontCheng =double.Parse( File.ReadAllText(pathwindontcheng));
            DatabaseCreator();
            if (File.ReadAllText(pathlosedontcheng).Length == 0)
            {
                File.WriteAllText(pathlosedontcheng, "" + 0 + "");
            }
            gameloseWhendontCheng =  double.Parse( File.ReadAllText(pathlosedontcheng));
            if (File.ReadAllText(pathwinwhencheng).Length == 0)
            {
                File.WriteAllText(pathwinwhencheng, "" + 0 + "");
            }
            gamewinWhenChengSelect = double.Parse(File.ReadAllText(pathwinwhencheng));
            DatabaseCreator();
            if (File.ReadAllText(pathlosewhencheng).Length == 0)
            {
                File.WriteAllText(pathlosewhencheng, "" + 0 + "");
            }
            gameloseWhenChengSelect = double.Parse(File.ReadAllText(pathlosewhencheng));
            DatabaseCreator();
            if (File.ReadAllText(pathturn).Length == 0)
            {
                File.WriteAllText(pathturn, "" + 0+ "");
            }
            gameturn = double.Parse( File.ReadAllText(pathturn));
            DatabaseCreator();
            if (File.ReadAllText(pathavgwin).Length == 0)
            {
                File.WriteAllText(pathavgwin, "" + 0 + "");
            }
            gameavgwinwhenselectCH = double.Parse( File.ReadAllText(pathavgwin));
            DatabaseCreator();
            if (File.ReadAllText(pathavglose).Length == 0)
            {
                File.WriteAllText(pathavglose, "" + 0 + "");
            }
            gameavgwinwithoutselectCH = double.Parse(File.ReadAllText(pathavglose));
        }
        private void chous()
        {

            while (true)
            {
                var pickd = random.Next(1, 3);
                if (pickd == 1 || pickd == 2 || pickd == 3)
                {
                    pick = pickd;
                    break;
                }
            }
            
        }
        private void GamePlayWITHCHENG(int ch)
        {
                gameturn++;
            if (ch == 1)
            {
                chous();

                if (pick == 1)
                {


                    int chou = 3;

                    if (chou == 3)
                    {
                        gamewinWhenChengSelect++;
                        avg();
                    }
                    else
                    {
                        gameloseWhenChengSelect++;
                        avg();
                    }

                }
                if (pick == 2)
                {


                    int chou = 1;

                    if (chou == 3)
                    {

                        gamewinWhenChengSelect++;
                        avg();
                    }
                    else
                    {
                        gameloseWhenChengSelect++;
                        avg();
                    }
                }
                if (pick == 3)
                {


                    int chou = 1;

                    if (chou == 3)
                    {
                        gamewinWhenChengSelect++;
                        avg();
                    }
                    else
                    {
                        gameloseWhenChengSelect++;
                        avg();
                    }
                }
            }
            if (ch == 2)
            {
                chous();

                if (pick == 1)
                {
                    

                        int chou = 3;

                        if (chou == 1)
                        {
                            gamewinWhenChengSelect++;
                            avg();
                        }
                        else
                        {
                            gameloseWhenChengSelect++;
                            avg();
                        }
                 
                }
                if (pick == 2)
                {
                    

                        int chou = 1;

                        if (chou == 1)
                        {

                            gamewinWhenChengSelect++;
                            avg();
                        }
                        else
                        {
                            gameloseWhenChengSelect++;
                            avg();
                        }
                }
                if (pick == 3)
                {
                   
  
                        int chou = 1;

                        if (chou == 1)
                        {
                            gamewinWhenChengSelect++;
                            avg();
                        }
                        else
                        {
                            gameloseWhenChengSelect++;
                            avg();
                        }
                }
            }
            if (ch == 3)
            {
                chous();

                if (pick == 1)
                {
                    
                        int chou =2;

                        if (chou == 2)
                        {
                            gamewinWhenChengSelect++;
                            avg();
                        }
                        else
                        {
                            
                            gameloseWhenChengSelect++;
                            avg();
                           
                        }
                }
                if (pick == 2)
                {
      
                        int chou = 3;

                        if (chou == 2)
                        {
                            gamewinWhenChengSelect++;
                            avg();
                            
                        }
                        else
                        {
                            gameloseWhenChengSelect++;
                            avg();
                        }
                }
                if (pick == 3)
                {
    
                        int chou = 2;

                        if (chou == 2)
                        {
                            gamewinWhenChengSelect++;
                        avg();
                            
                        }
                        else
                        {
                            gameloseWhenChengSelect++;
                            avg();
                        }
                }
            }
        }
        private void GamePlayWITHOUTCHENG(int ch)
        {
            gameturn++;
            if (ch == 1)
            {
                chous();

                if (pick == 1)
                {


                    int chou = 1;

                    if (chou == 3)
                    {
                        gamewinWhendontCheng++;
                        avg();
                    }
                    else
                    {
                        gameloseWhendontCheng++;
                        avg();
                    }
                }
                if (pick == 2)
                {


                    int chou = 2;


                    if (chou == 3)
                    {

                        gamewinWhendontCheng++;
                        avg();

                    }
                    else
                    {
                        gameloseWhendontCheng++;
                        avg();

                    }
                }
                if (pick == 3)
                {

                    int chou = 3;


                    if (chou == 3)
                    {
                        gamewinWhendontCheng++;
                        avg();
                    }
                    else
                    {
                        gameloseWhendontCheng++;
                        avg();
                    }
                }
            }
            if (ch == 2)
            {
                chous();

                if (pick == 1)
                {
                    

                        int chou = 1;
 
                        if (chou == 1)
                        {
                            gamewinWhendontCheng++;
                            avg();
                        }
                        else
                        {
                            gameloseWhendontCheng++;
                            avg();
                        }
                }
                if (pick == 2)
                {
                 
                     
                        int chou = 2;
                      

                        if (chou == 1)
                        {

                            gamewinWhendontCheng++;
                            avg();
                            
                        }
                        else
                        {
                            gameloseWhendontCheng++;
                            avg();
                           
                        }
                }
                if (pick == 3)
                {
                
                        int chou = 3;
                    

                        if (chou == 1)
                        {
                            gamewinWhendontCheng++;
                            avg();
                        }
                        else
                        {
                            gameloseWhendontCheng++;
                            avg();
                        }
                }
            }
            if (ch == 3)
            {
                chous();

                if (pick == 1)
                {
                    
                        int chou = 1;

                        if (chou == 2)
                        {
                            gamewinWhendontCheng++;
                            avg();
                        }
                        else
                        {
                            gameloseWhendontCheng++;
                            avg();
                        }
                }
                if (pick == 2)
                {
 
                        int chou = 2;

                        if (chou == 2)
                        {
                            gamewinWhendontCheng++;
                            avg();
                        }
                        else
                        {
                            gameloseWhendontCheng++;
                            avg();
                        }
                }
                if (pick == 3)
                {
             
                        int chou = 3;

                        if (chou == 2)
                        {
                            gamewinWhendontCheng++;
                            avg();
                        }
                        else
                        {
                            gameloseWhendontCheng++;
                            avg();
                        }
                }
            }
        }
        public void Start() 
        {
            avragereader();
            while (true)
            {
                var showc = random.Next(1, 3);
                switch (showc)
                {
                    case 1:
                        // dor 1 = goat
                        // dor 2 = jurk
                        // dor 3 = car
                        long counter1 = 0;
                        long counter2 = 0;
                        while (true)
                        {
                            GamePlayWITHCHENG(showc);

                            counter1++;
                            if (counter1 == 500)
                            {
                                counter1 = 0;
                                break;
                            }
                        }
                        while (true)
                        {
                            GamePlayWITHOUTCHENG(showc);

                            counter2++;
                            if (counter2 == 500)
                            {
                                counter2 = 0;
                                break;
                            }
                        }

                        break;
                    case 2:
                        // dor 1 = car
                        // dor 2 = jurk
                        // dor 3 = goat
                        long counter3 = 0;
                        long counter4 = 0;
                        while (true)
                        {
                            GamePlayWITHCHENG(showc);

                            counter3++;
                            if (counter3 == 500)
                            {
                                counter3 = 0;
                                break;
                            }
                        }
                       
                        while (true)
                        {
                            GamePlayWITHOUTCHENG(showc);

                            counter4++;
                            if (counter4 == 500)
                            {
                                counter4 = 0;
                                break;
                            }
                        }
                        
                        break;
                    case 3:
                        // dor 1 = goat
                        // dor 2 = car
                        // dor 3 = jurk
                        long counter5 = 0;
                        long counter6 = 0;
                        while (true)
                        {
                            GamePlayWITHCHENG(showc);

                            counter5++;
                            if (counter5 == 500)
                            {
                                counter5 = 0;
                                break;
                            }
                        }

                        while (true)
                        {

                            GamePlayWITHOUTCHENG(showc);

                            counter6++;
                            if (counter6 == 500)
                            {
                                counter6 = 0;
                                break;
                            }
                        }
                        
                        break;

                    default:
                        break;
                }
                Console.WriteLine("rate of win with chenging : " + gamewinWhenChengSelect + "\n");
                Console.WriteLine("rate of win without chenging : " + gamewinWhendontCheng + "\n");
                Console.WriteLine("rate of lose with chenging : " + gameloseWhenChengSelect + "\n");
                Console.WriteLine("rate of lose without chenging : " + gameloseWhendontCheng + "\n");
                Console.WriteLine(" ALL TURN : " + gameturn + "\n" );
                Console.WriteLine("avrage win with chenging  :  " + gameavgwinwhenselectCH + "%\n");
                Console.WriteLine("avrage win without chenging :  " + gameavgwinwithoutselectCH + "%\n");
                Console.WriteLine("avrage lose with chenging  :  " + gameavglosewhenselectCH + "%\n");
                Console.WriteLine("avrage lose without chenging :  " + gameavglosewithoutselectCH + "%\n");
                Console.WriteLine("do u want play leave And save the avrage ?");
                var acc = Console.ReadKey().KeyChar.ToString();
                if (acc == "y")
                {
                    avrageSetter();
                    break;
                }
                else
                {
                    Console.Clear();
                }
                
            }

        }
    }
}
