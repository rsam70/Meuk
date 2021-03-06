using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meuk
{
    class ExpressionMembersExample
    {
        public ExpressionMembersExample(string label) => this.Label = label;

        // Expression-bodied finalizer
        ~ExpressionMembersExample() => Console.Error.WriteLine("Finalized!");

        private string label;

        // Expression-bodied get / set accessors.
        public string Label
        {
            get => label;
            set => this.label = value ?? "Default label";
        }
    }
}
