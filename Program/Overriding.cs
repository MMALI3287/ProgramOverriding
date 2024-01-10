namespace Program
{
    internal class Overriding
    {
        public void ExploreOverRiding(String roll)
        {
            var checkedRoll = checkRoll(roll);
            Console.WriteLine("Roll Matched in OverRiding: " + checkedRoll);
        }

        public virtual void saveRoll(string roll)
        {

        }

        public virtual bool checkRoll(string roll)
        {
            return true;
        }


    }
}
