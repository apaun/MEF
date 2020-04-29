using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class HostMef
    {

        [Import]
        private IOperation _operation;

        private CompositionContainer _container;

        public HostMef()
        {
            //var oper = new AddOpertion();

            var location = Assembly.GetExecutingAssembly().Location;
            var catalog = new DirectoryCatalog(Path.GetDirectoryName(location), "*.dll");
            _container = new CompositionContainer(catalog);

            // 1.
            //var batch = new CompositionBatch();
            //batch.AddPart(this);
            //_container.Compose(batch);

            // 2.
            _container.ComposeParts(this);

            // 3.
            //_operations = _container.GetExportedValues<IOperation>().ToList();

        }
        public void Run()
        {
            Console.WriteLine(_operation.Perform(10, 20));
        }

    }
}
