namespace Lesson16_练习题
{
    class Vehicle‌

    {
        public float speed;
        private float speadMax;
        private int peopleNum;
        private int driverNum;
        public int passengerNum;

        public Vehicle()
        {
            speed = 0;
            speadMax = 120f;
            peopleNum = 30;
            driverNum = 1;
            passengerNum = 0;
        }
        public void GetVehicle(int i)
        {
            if (i < peopleNum - driverNum - passengerNum)
            {
                Console.WriteLine("{0}位乘客上车了", i);
                passengerNum = passengerNum + i;
            }
            else
            {
                Console.WriteLine("{0}位乘客上车了", i);
                passengerNum = passengerNum + i;
            }


        }
        public void OffVehicle()
        {

        }
        public void Drive()
        {

        }
        public void CarAccidengt()
        {

        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson16_继承_密封类");


            Vehicle‌ vehicle = new Vehicle();
        }
    }
}
