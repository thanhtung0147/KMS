using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OanTuTi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chào mừng các bạn đến với game kéo búa bao");
            Console.WriteLine("Luật chơi:\n Kéo = 1 \t Búa = 2 \t Bao = 3");
            Console.WriteLine("Kéo thắng Búa , Búa thắng Bao ,  Bao Thắng Kéo");
            Console.WriteLine("Are you ready!!!!");
            Console.WriteLine("Let's go");
            string a;
            do
            {
                Console.WriteLine("Chơi với máy chọn 1 \nChơi 2 người chọn 2");
                Console.Write("Bạn muốn chơi mấy người?:");
                int snc = int.Parse(Console.ReadLine());

                {
                    switch (snc)
                    {

                        case 1:
                            {

                                Console.Write("Mời bạn chọn: ");
                                int nc1 = int.Parse(Console.ReadLine());
                                {
                                    if (nc1 == 1)
                                    {
                                        Console.WriteLine("------------->Bạn chọn Kéo");
                                    }
                                    if (nc1 == 2)
                                    {
                                        Console.WriteLine("------------->Bạn chọn Búa");
                                    }
                                    if (nc1 == 3)
                                    {
                                        Console.WriteLine("------------->Bạn chọn Bao");
                                    }
                                }

                                Random rd = new Random();
                                int may = rd.Next(1, 3);
                                {
                                    if (may == 1)
                                    {
                                        Console.WriteLine("------------->Máy chọn Kéo");
                                    }
                                    if (may == 2)
                                    {
                                        Console.WriteLine("------------->Máy chọn Búa");
                                    }
                                    if (may == 3)
                                    {
                                        Console.WriteLine("------------->Máy chọn Bao");
                                    }
                                }


                                if (nc1 == may)
                                {
                                    Console.WriteLine("--------------HÒA NHA----------------");
                                }
                                if (nc1 == 1 && may == 2 || nc1 == 2 && may == 3 || nc1 == 3 && may == 1)
                                {
                                    Console.WriteLine("-----------------BẠN THẮNG--------------------");
                                }

                                if (nc1 == 2 && may == 1 || nc1 == 3 && may == 3 || nc1 == 1 && may == 3)
                                {
                                    {
                                        Console.WriteLine("----------------TAO THẮNG--------------------");
                                    }
                                }



                                break;
                            }
                        case 2:
                            {
                                Console.Write("Mời bạn A chọn nè: ");
                                int nc1 = int.Parse(Console.ReadLine());
                                {
                                    if (nc1 == 1)
                                    {
                                        Console.WriteLine("------------->Bạn chọn Kéo");
                                    }
                                    if (nc1 == 2)
                                    {
                                        Console.WriteLine("------------->Bạn chọn Búa");
                                    }
                                    if (nc1 == 3)
                                    {
                                        Console.WriteLine("------------->Bạn chọn Bao");
                                    }
                                }


                                Console.Write("Mời bạn B chọn nè: ");
                                int nc2 = int.Parse(Console.ReadLine());
                                {
                                    if (nc2 == 1)
                                    {
                                        Console.WriteLine("------------->Bạn chọn Kéo");
                                    }
                                    if (nc2 == 2)
                                    {
                                        Console.WriteLine("------------->Bạn chọn Búa");
                                    }
                                    if (nc2 == 3)
                                    {
                                        Console.WriteLine("------------->Bạn chọn Bao");
                                    }
                                }

                                if (nc1 == nc2)
                                {
                                    Console.WriteLine("--------------HÒA NHA----------------");
                                }
                                if (nc1 == 1 && nc2 == 2 || nc1 == 2 && nc2 == 3 || nc1 == 3 && nc2 == 1)
                                {
                                    Console.WriteLine("-----------------BẠN A THẮNG--------------------");
                                }

                                if (nc1 == 2 && nc2 == 1 || nc1 == 3 && nc2 == 3 || nc1 == 1 && nc2 == 3)
                                {
                                    {
                                        Console.WriteLine("-----------------BẠN B THẮNG--------------------");
                                    }
                                }


                                break;
                            }
                        default:
                            Console.WriteLine("Bạn chọn sai rồi");
                            break;
                    }

                }

                Console.WriteLine("Bạn có muốn chơi tiếp không? !!!!!!! Có chọn c or C nha");
                a = Console.ReadLine();

            }
            while (a == "c" || a == "C");


            Console.ReadKey();
        }
    }
}
