﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.ModelConfiguration.Configuration.Functions
{
    using System.Data.Entity.Migrations;
    using Xunit;

    public class ModificationFunctionsConfigurationTTests
    {
        [Fact]
        public void Insert_when_config_action_should_call_method_on_internal_configuration()
        {
            var modificationFunctionsConfiguration = new ModificationStoredProceduresConfiguration<Order>();

            ModificationStoredProcedureConfigurationBase configuration = null;

            modificationFunctionsConfiguration.Insert(c => { configuration = c; });

            Assert.Same(
                configuration.Configuration,
                modificationFunctionsConfiguration.Configuration.InsertModificationStoredProcedureConfiguration);
        }

        [Fact]
        public void Update_when_config_action_should_call_method_on_internal_configuration()
        {
            var modificationFunctionsConfiguration = new ModificationStoredProceduresConfiguration<Order>();

            ModificationStoredProcedureConfigurationBase configuration = null;

            modificationFunctionsConfiguration.Update(c => { configuration = c; });

            Assert.Same(
                configuration.Configuration,
                modificationFunctionsConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration);
        }

        [Fact]
        public void Delete_when_config_action_should_call_method_on_internal_configuration()
        {
            var modificationFunctionsConfiguration = new ModificationStoredProceduresConfiguration<Order>();

            ModificationStoredProcedureConfigurationBase configuration = null;

            modificationFunctionsConfiguration.Delete(c => { configuration = c; });

            Assert.Same(
                configuration.Configuration,
                modificationFunctionsConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration);
        }
    }
}
