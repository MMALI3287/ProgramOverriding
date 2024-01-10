namespace Program
{
    internal class OverridingImplementation : Overriding
    {
        public string roll = "";

        public void ImplementOverRiding(String roll, String testRoll)
        {
            saveRoll(testRoll);
            var checkedRoll = checkRoll(roll);
            Console.WriteLine("Roll Matched in OverridingImplementation: " + checkedRoll);
        }

        public override void saveRoll(string roll)
        {
            this.roll = roll;
        }

        public override bool checkRoll(String realRoll)
        {
            if (this.roll == realRoll)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
