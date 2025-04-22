namespace XOXoyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
           

            string[,] tahta = new string[3, 3];

            

            Console.WriteLine($"    {tahta[0,0]}         {tahta[0,1]}         {tahta[0,2]}");
            Console.WriteLine("--------|---------|---------\n");
            Console.WriteLine($"    {tahta[1,0]}         {tahta[1,1]}         {tahta[1,2]}");
            Console.WriteLine("--------|---------|---------\n");
            Console.WriteLine($"    {tahta[2,0]}         {tahta[2,1]}         {tahta[2,2]}");
            Console.WriteLine("--------|---------|---------");

            int i1;
            int i2;

            bool oyunBittimi = false;
            while (oyunBittimi != true)
            {
                Console.WriteLine("Birinci oyuncunun sırası: ");
                i1 = int.Parse(Console.ReadLine());
                switch (i1)
                {
                    case 1:
                        if (tahta[0, 0] == null)
                        {
                            tahta[0, 0] = "X";
                        }
                        else
                        {
                            Console.WriteLine("Bu hane dolu!");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "X"))
                        {
                            Console.WriteLine("Birinci oyuncu (X) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 2:
                        if (tahta[0, 1] == null) { 
                            tahta[0, 1] = "X"; }
                        else
                        {
                            Console.WriteLine("Bu hane dolu!");    
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "X"))
                        {
                            Console.WriteLine("Birinci oyuncu (X) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 3:
                        if (tahta[0, 2] == null)
                        {
                            tahta[0, 2] = "X";
                        }
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "X"))
                        {
                            Console.WriteLine("Birinci oyuncu (X) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 4:
                        if (tahta[1, 0] == null)
                        {
                            tahta[1, 0] = "X";
                        }
                        else
                        {
                            Console.WriteLine("Bu hane dolu");    
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "X"))
                        {
                            Console.WriteLine("Birinci oyuncu (X) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 5:
                        if (tahta[1, 1] == null) { tahta[1, 1] = "X"; }
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "X"))
                        {
                            Console.WriteLine("Birinci oyuncu (X) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 6:
                        if (tahta[1,2]==null)tahta[1, 2] = "X";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "X"))
                        {
                            Console.WriteLine("Birinci oyuncu (X) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 7:
                        if (tahta[2,0]==null)tahta[2, 0] = "X";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "X"))
                        {
                            Console.WriteLine("Birinci oyuncu (X) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 8:
                        if (tahta[2,1]==null)tahta[2, 1] = "X";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "X"))
                        {
                            Console.WriteLine("Birinci oyuncu (X) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 9:
                        if (tahta[2,2]==null)tahta[2, 2] = "X";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "X"))
                        {
                            Console.WriteLine("Birinci oyuncu (X) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                }
                Console.WriteLine("İkinci oyuncunun sırası");
                i2 = int.Parse(Console.ReadLine());
                switch (i2)
                {
                    case 1:
                        if (tahta[0,0]==null)tahta[0,0] = "O";    
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "O"))
                        {
                            Console.WriteLine("İkinci oyuncu (O) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 2:
                        if (tahta[0,1]==null)tahta[0,1] = "O";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "O"))
                        {
                            Console.WriteLine("İkinci oyuncu (O) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 3:
                        if (tahta[0,2]==null)tahta[0,2] = "O";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "O"))
                        {
                            Console.WriteLine("İkinci oyuncu (O) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 4:
                        if (tahta[1,0]==null)tahta[1,0] = "O";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "O"))
                        {
                            Console.WriteLine("İkinci oyuncu (O) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 5:
                        if (tahta[1,1]==null)tahta[1, 1]="O";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "O"))
                        {
                            Console.WriteLine("İkinci oyuncu (O) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 6:
                        if (tahta[1,2]==null)tahta[1, 2] = "O";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                     
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "O"))
                        {
                            Console.WriteLine("İkinci oyuncu (O) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 7:
                        if (tahta[2,0]==null)tahta[2, 0] = "O";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "O"))
                        {
                            Console.WriteLine("İkinci oyuncu (O) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 8:
                        if (tahta[2,1]==null)tahta[2, 1] = "O";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                       
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "O"))
                        {
                            Console.WriteLine("İkinci oyuncu (O) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                    case 9:
                        if (tahta[2,2]==null)tahta[2, 2]= "O";
                        else
                        {
                            Console.WriteLine("Bu hane dolu");
                        }
                        Console.WriteLine($"    {tahta[0, 0]}         {tahta[0, 1]}         {tahta[0, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[1, 0]}         {tahta[1, 1]}         {tahta[1, 2]}");
                        Console.WriteLine("--------|---------|---------\n");
                        Console.WriteLine($"    {tahta[2, 0]}         {tahta[2, 1]}         {tahta[2, 2]}");
                        Console.WriteLine("--------|---------|---------");
                        if (KazananVarMi(tahta, "O"))
                        {
                            Console.WriteLine("İkinci oyuncu (O) kazandı!");
                            oyunBittimi = true;
                        }
                        break;
                }
                





            }
            
        }
        static bool KazananVarMi(string[,] tahta, string oyuncu)
        {
            // Satır ve sütun kontrolü
            for (int i = 0; i < 3; i++)
            {
                if (tahta[i, 0] == oyuncu && tahta[i, 1] == oyuncu && tahta[i, 2] == oyuncu)
                    return true;
                if (tahta[0, i] == oyuncu && tahta[1, i] == oyuncu && tahta[2, i] == oyuncu)
                    return true;
            }

            // Çapraz kontrol
            if (tahta[0, 0] == oyuncu && tahta[1, 1] == oyuncu && tahta[2, 2] == oyuncu)
                return true;
            if (tahta[0, 2] == oyuncu && tahta[1, 1] == oyuncu && tahta[2, 0] == oyuncu)
                return true;

            return false;
        }
    }
}
