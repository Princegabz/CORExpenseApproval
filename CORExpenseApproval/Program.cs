namespace CORExpenseApproval
{
    class Program
    {
        static void Main(string[] args) 
        {
            ApprovalBase TwoDigit = new DoubleDigit();
            ApprovalBase ThreeDigit = new TripleDigit();
            ApprovalBase fourDigit = new QuadDigit();
            ApprovalBase MoreDigit = new ThatsAlot();

            TwoDigit.SetSuccessor(ThreeDigit);
            ThreeDigit.SetSuccessor(fourDigit);
            fourDigit.SetSuccessor(MoreDigit);

            string? Result = null;

            TwoDigit.DigitChecker(10,Result);
            Console.WriteLine(Result);

        }
        public abstract class ApprovalBase 
        {
            protected ApprovalBase _Successor;

            public abstract void DigitChecker(int Digits, string Result);

            public void SetSuccessor(ApprovalBase Successor)
            {
                _Successor=Successor; 
            }
        }

        public class DoubleDigit : ApprovalBase
        {
            public override void DigitChecker(int Digits, string Result)
            {
                if (Digits == 2) 
                {
                    Console.WriteLine("DoubleDigit checker approves Amount");
                }
                else
                {
                    Console.WriteLine("DoubleDigit checker passes Amount to superior checker");
                    _Successor.DigitChecker(Digits, Result);
                }
            }
        }
        public class TripleDigit : ApprovalBase
        {
            public override void DigitChecker(int Digits, string Result)
            {
                if (Digits == 3)
                {
                    Console.WriteLine("TripleDigit checker approves Amount");
                }
                else
                {
                    Console.WriteLine("TripleDigit checker passes Amount to superior checker");
                    _Successor.DigitChecker(Digits, Result);
                }
            }
        }

        public class QuadDigit : ApprovalBase
        {
            public override void DigitChecker(int Digits, string Result)
            {
                if (Digits == 4)
                {
                    Console.WriteLine("QuadDigit checker approves Amount");
                }
                else
                {
                    Console.WriteLine("QuadDigit checker passes Amount to superior checker");
                    _Successor.DigitChecker(Digits, Result);
                }
            }
        }
        public class ThatsAlot : ApprovalBase
        {
            public override void DigitChecker(int Digits, string Result)
            {
                if (Digits > 4)
                {
                    Console.WriteLine("ThatsAlot checker approves Amount");
                }
                else
                {
                    Console.WriteLine("ThatsAlot checker passes Amount to superior checker");
                    _Successor.DigitChecker(Digits, Result);
                }
            }
        }
    }
}
