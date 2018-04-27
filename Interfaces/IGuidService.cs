using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore11_01.Interfaces
{
    public interface IGuidService
    {
        Guid GetID();
    }

    public interface INewAlwaysGuidService : IGuidService
    {

    }
    public interface INewGuidService : IGuidService
    {

    }
    public interface IInstanceGuidService : IGuidService
    {

    }

    public class NewAlwaysGuidService : INewAlwaysGuidService
    {
        public NewAlwaysGuidService()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID;
        public Guid GetID()
        {
            return ID;
        }
    }
    public class NewGuidService : INewGuidService
    {
        public NewGuidService()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID;
        public Guid GetID()
        {
            return ID;
        }
    }
    public class InstanceGuidService : IInstanceGuidService
    {
        public InstanceGuidService()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID;
        public Guid GetID()
        {
            return ID;
        }
    }
}
