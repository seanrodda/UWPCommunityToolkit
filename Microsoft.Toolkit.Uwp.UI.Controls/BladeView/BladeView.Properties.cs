﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System.Collections.Generic;
using Windows.UI.Xaml;

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    /// <summary>
    /// A container that hosts <see cref="BladeItem"/> controls in a horizontal scrolling list
    /// Based on the Azure portal UI
    /// </summary>
    public partial class BladeView
    {
        /// <summary>
        /// Identifies the <see cref="ActiveBlades"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ActiveBladesProperty = DependencyProperty.Register(nameof(ActiveBlades), typeof(IList<BladeItem>), typeof(BladeView), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets a collection of visible blades
        /// </summary>
        public IList<BladeItem> ActiveBlades
        {
            get { return (IList<BladeItem>)GetValue(ActiveBladesProperty); }
            set { SetValue(ActiveBladesProperty, value); }
        }
    }
}
