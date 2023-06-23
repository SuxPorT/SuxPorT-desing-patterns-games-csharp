﻿namespace DesignPatterns.Behavioural.Command.RobotControl
{
    public class ComplexCommand : ICommand
    {
        private readonly Receiver _receiver;
        private readonly string _a;
        private readonly string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            _receiver.FirstRequest(_a);
            _receiver.SecondRequest(_b);
        }
    }
}
