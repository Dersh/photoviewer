﻿using System.Collections.Generic;
using System.Reflection;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Logging;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Plugin;

namespace photoviewer.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override IEnumerable<Assembly> AndroidViewAssemblies =>
            new List<Assembly>(base.AndroidViewAssemblies)
            {
                typeof(MvxRecyclerView).Assembly
            };

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);
        }

        public override void LoadPlugins(IMvxPluginManager pluginManager)
        {
            base.LoadPlugins(pluginManager);
        }
    }
}