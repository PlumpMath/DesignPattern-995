﻿namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA e)
        {
            e.OperationA();
            Console.WriteLine(
                "{0} visited by {1}", e.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB e)
        {
            e.OperationB();
            Console.WriteLine(
                "{0} visited by {1}", e.GetType().Name, this.GetType().Name);
        }
    }
}