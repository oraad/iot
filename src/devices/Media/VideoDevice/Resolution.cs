﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;

namespace Iot.Device.Media
{
    /// <summary>
    /// The resolution type of a video device.
    /// </summary>
    public enum ResolutionType : uint
    {
        /// <summary>
        /// Discrete
        /// </summary>
        Discrete = v4l2_frmsizetypes.V4L2_FRMSIZE_TYPE_DISCRETE,

        /// <summary>
        /// Continuous
        /// </summary>
        Continuous = v4l2_frmsizetypes.V4L2_FRMSIZE_TYPE_CONTINUOUS,

        /// <summary>
        /// Stepwise
        /// </summary>
        Stepwise = v4l2_frmsizetypes.V4L2_FRMSIZE_TYPE_STEPWISE
    }

    /// <summary>
    /// Resolution's interface
    /// </summary>
    public interface IResolution
    {
        /// <summary>
        /// Resolution's type
        /// </summary>
        ResolutionType Type { get; }
    }

    /// <summary>
    /// The discrete resolution of a video device.
    /// </summary>
    public class DiscreteResolution : IResolution
    {
        /// <summary>
        /// Resolution's type
        /// </summary>
        public ResolutionType Type => ResolutionType.Discrete;

        /// <summary>
        /// Resolution's height
        /// </summary>
        public uint Height { get; set; }

        /// <summary>
        /// Resolution's width
        /// </summary>
        public uint Width { get; set; }
    }

    /// <summary>
    /// The continuous resolution of a video device.
    /// </summary>
    public class ContinuousResolution : IResolution
    {
        /// <summary>
        /// Resolution's type
        /// </summary>
        public ResolutionType Type => ResolutionType.Continuous;

        /// <summary>
        /// Resolution's minimum height
        /// </summary>
        public uint MinHeight { get; set; }

        /// <summary>
        /// Resolution's maximum height
        /// </summary>
        public uint MaxHeight { get; set; }

        /// <summary>
        /// Resolution's minimum width
        /// </summary>
        public uint MinWidth { get; set; }

        /// <summary>
        /// Resolution's maximum width
        /// </summary>
        public uint MaxWidth { get; set; }
    }

    /// <summary>
    /// The stepwise resolution of a video device.
    /// </summary>
    public class StepwiseResolution : IResolution
    {
        /// <summary>
        /// Resolution's type
        /// </summary>
        public ResolutionType Type => ResolutionType.Stepwise;

        /// <summary>
        /// Resolution's minimum height
        /// </summary>
        public uint MinHeight { get; set; }

        /// <summary>
        /// Resolution's maximum height
        /// </summary>
        public uint MaxHeight { get; set; }

        /// <summary>
        /// Resolution's step for height
        /// </summary>
        public uint StepHeight { get; set; }

        /// <summary>
        /// Resolution's minimum width
        /// </summary>
        public uint MinWidth { get; set; }

        /// <summary>
        /// Resolution's maximum width
        /// </summary>
        public uint MaxWidth { get; set; }

        /// <summary>
        /// Resolution's step for width
        /// </summary>
        public uint StepWidth { get; set; }
    }
}
