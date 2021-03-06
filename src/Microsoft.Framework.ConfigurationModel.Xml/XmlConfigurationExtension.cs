// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Framework.ConfigurationModel
{
    public static class XmlConfigurationExtension
    {
        public static IConfigurationSourceRoot AddXmlFile(this IConfigurationSourceRoot configuration, string path)
        {
            configuration.Add(new XmlConfigurationSource(path));
            return configuration;
        }
    }
}
