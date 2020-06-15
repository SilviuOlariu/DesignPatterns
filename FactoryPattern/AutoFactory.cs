using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;

namespace FactoryPattern
{
    public  class AutoFactory
    {
        Dictionary<string, Type> autos;
       
        public AutoFactory()
        {
            LoadTypesICanRun();
        }

        private void LoadTypesICanRun()
        {
            autos = new Dictionary<string, Type>();

            Type[] TypesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in TypesInThisAssembly)
            {
                if (type.GetInterface(typeof(IAuto).ToString()) !=null)
                {
                    autos.Add(type.Name.ToLower(), type);
                }
            }
            
        }
        Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if(auto.Key.Contains(carName))
                {
                    return autos[auto.Key];
                }
               
            }
            return null;

        }

        public IAuto  CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);

            if(t == null)
            {
                return new NullCar();
            }
            else
            {
                return Activator.CreateInstance(t) as IAuto;
            }
            
        }
    }
}