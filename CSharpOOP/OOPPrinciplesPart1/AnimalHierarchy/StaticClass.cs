namespace AnimalHierarchy
{
    public static class StaticClass
    {
        //  calculate the average age of each kind of animal
        public static double CalcAvgAge(Animal[] animals)
        {
            double avg = 0;
            int sum = 0;
            int count = 0;

            foreach (Animal animal in animals)
            {
                sum += animal.Age;
                count++;
            }

            avg = sum / (double)count;
            return avg;
        }
    }
}
