using System;

namespace Calculator_library
{
    public class Library
    {
        public static int Sum(String series)
        {
            int result = 0;

            String[] numbers = series.Split(' ');


            foreach (string number in numbers)
            {

                int temp;


                if (int.TryParse(number, out temp))
                {

                    result += temp;
                }
                else
                {
                    throw new ArgumentException();
                }

            }


            return result;


        }
        public static int Sub(String series)
        {
            int result = 0;

            String[] numbers = series.Split(' ');


            foreach (string number in numbers)
            {

                int temp;


                if (int.TryParse(number, out temp))
                {

                    result -= temp;
                }
                else
                {
                    throw new ArgumentException();
                }

            }


            return result;
        }
    }
}


