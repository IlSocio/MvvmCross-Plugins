// MvxThreadSleep.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using System.Threading;

namespace MvvmCross.Plugins.ThreadUtils.WindowsPhone
{
    public class MvxThreadSleep : IMvxThreadSleep
    {
        #region Implementation of IMvxThreadSleep

        public void Sleep(TimeSpan t)
        {
            Thread.Sleep(t);
        }

        #endregion Implementation of IMvxThreadSleep
    }
}