namespace JPZT_for_laborotorna_5
{
    public class Program
    {

         public static int CalculateResult(bool par2, int par3)
        {
            int result;


            switch (par3) {
                case 47:
                case 68:
                case 90:
                    result = par3;
                    break;
                default:
                    result = 91;
                    break;
            }
            int var = 0;
            if (var < result)
            {
                var += 3;
                result += var;
            }
                
            return result;
        }
        static void Main(string[] args)
        {
            int result = CalculateResult(false, 90);
            Console.WriteLine(result);
        }
    }
}
