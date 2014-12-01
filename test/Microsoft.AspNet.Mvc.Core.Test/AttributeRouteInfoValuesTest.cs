﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc.ApplicationModels;
using Xunit;

namespace Microsoft.AspNet.Mvc.Logging
{
    public class AttributeRouteInfoValuesTest
    {
        [Fact]
        public void AssertAttributeRouteModelValuesPropertiesMatchAttributeRouteModelProperties()
        {
            // Arrange
            string[] exclude = { "Attribute" };

            // Assert
            PropertiesHelper.AssertPropertiesAreTheSame(
                typeof(AttributeRouteModel), 
                typeof(AttributeRouteModelValues), 
                exclude);
        }
    }
}