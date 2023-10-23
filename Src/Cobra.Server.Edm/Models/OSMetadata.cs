﻿using Cobra.Server.Edm.Models.Base;

namespace Cobra.Server.Edm.Models
{
    public class OSMetadata
    {
        public class Schema
        {
            public string Namespace { get; set; }
            public List<EdmEntityType> EntityTypes { get; set; }
            public List<EdmComplexType> ComplexTypes { get; set; }
            public List<EdmAssociation> Associations { get; set; }
            public List<EntityContainer> EntityContainers { get; set; }
        }

        public class EntityContainer
        {
            public List<EdmEntitySet> EntitySets { get; set; }
            public List<EdmFunctionImport> FunctionImports { get; set; }
        }

        public EdmClientConfiguration ClientConfiguration { get; set; }
        public List<Schema> Schemas { get; set; }
    }
}
