﻿// MvxWpfLifetimeMonitor.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.MvvmCross.Platform;

namespace Cirrious.MvvmCross.Wpf.Platform
{
    public class MvxWpfLifetimeMonitor : MvxLifetimeMonitor
    {
        public MvxWpfLifetimeMonitor()
        {
            //PhoneApplicationService.Current.Activated += (s, e) =>
            //    {
            //        if (e.IsApplicationInstancePreserved)
            //            FireLifetimeChange(
            //                MvxLifetimeEvent.ActivatedFromMemory);
            //        else
            //            FireLifetimeChange(
            //                MvxLifetimeEvent.ActivatedFromDisk);
            //    };
            //PhoneApplicationService.Current.Closing += (s, e) => FireLifetimeChange(MvxLifetimeEvent.Closing);
            //PhoneApplicationService.Current.Deactivated += (s, e) => FireLifetimeChange(MvxLifetimeEvent.Deactivated);
            //PhoneApplicationService.Current.Launching += (s, e) => FireLifetimeChange(MvxLifetimeEvent.Launching);
        }
    }
}