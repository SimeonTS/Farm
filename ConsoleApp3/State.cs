using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface StateBase

    {
        void Change(Context context);
    }
    public class StateA : StateBase

    {

        public void Change(Context context)

        {

            //Change state from A to B.

            context.State = new StateB();

            Console.WriteLine("Change state from A to B.");

        }

    }



    public class StateB : StateBase

    {

        public void Change(Context context)

        {

            //Change state from B to C.

            context.State = new StateC();

            Console.WriteLine("Change state from B to C.");

        }

    }



    public class StateC : StateBase

    {

        public void Change(Context context)

        {

            //Change statefrom C to A.

            context.State = new StateA();

            Console.WriteLine("Change state from C to A.");

        }

    }
}