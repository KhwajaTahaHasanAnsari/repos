using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EnterpriseManagement;
using Microsoft.EnterpriseManagement.Common;
using Microsoft.EnterpriseManagement.Configuration;

namespace GetEmo
{
    class Class1
    {
        public Guid Guid;
        static void Main(string[] Args)
        {
            EnterpriseManagementGroup Emg = new EnterpriseManagementGroup("MIMSCSM");

            Guid g = new Guid(“2D7968F72AE76CE2627354D110A35A8A”);

            ManagementPack mpSystem = Emg.ManagementPacks.GetManagementPack(SystemManagementPack.System);

            ManagementPackRelationship relContainment = mpSystem.GetRelationship(“System.Containment”);

            TraversalDepth tdRecursive = TraversalDepth.Recursive;

            IList<EnterpriseManagementObject> listContainedObjects = Emg.EntityObjects.GetRelatedObjects<EnterpriseManagementObject>(guidObjectID, relContainment, tdRecursive, ObjectQueryOptions.Default);

            foreach (EnterpriseManagementObject emo in listContainedObjects)

            {

                Console.WriteLine(emo.DisplayName);

            }

        }
    }

}
