﻿// 
//  Copyright 2014 Gustavo J Knuppe (https://github.com/knuppe)
// 
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
// 
//       http://www.apache.org/licenses/LICENSE-2.0
// 
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// 
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//   - May you do good and not evil.                                         -
//   - May you find forgiveness for yourself and forgive others.             -
//   - May you share freely, never taking more than you give.                -
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//  

using System;

namespace SharpNL.Utility.Model {
    /// <summary>
    /// Provides data for events that contain the <see cref="ModelInfo"/>.
    /// </summary>
    public class ModelInfoEventArgs : EventArgs {

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfoEventArgs"/> class.
        /// </summary>
        /// <param name="modelInfo">The model information.</param>
        /// <exception cref="System.ArgumentNullException">modelInfo</exception>
        public ModelInfoEventArgs(ModelInfo modelInfo) {

            if (modelInfo == null)
                throw new ArgumentNullException("modelInfo");

            ModelInfo = modelInfo;

        }

        /// <summary>
        /// Gets the model information.
        /// </summary>
        /// <value>The model information.</value>
        public ModelInfo ModelInfo { get; private set; }

    }
}