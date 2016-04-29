﻿// Copyright (c) 2007-2016 CSJ2K contributors.
// Licensed under the BSD 3-Clause License.

namespace CSJ2K.Util
{
    public class WriteableBitmapImageCreator : IImageCreator
    {
        #region FIELDS

        private static readonly IImageCreator Instance = new WriteableBitmapImageCreator();

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets whether or not this type is classified as a default manager.
        /// </summary>
        public bool IsDefault
        {
            get
            {
                return true;
            }
        }

        #endregion

        #region METHODS

        public static void Register()
        {
            ImageFactory.Register(Instance);
        }

        public IImage Create(int width, int height, int numberOfComponents)
        {
            return new WriteableBitmapImage(width, height, numberOfComponents);
        }

        #endregion
    }
}
