namespace MiodenusAnimationConverter.Exceptions;

using System;

[Serializable]
public class ShaderCompileException : Exception
{
    public ShaderCompileException() {}
    public ShaderCompileException(string message) : base(message) {}
    public ShaderCompileException(string message, Exception inner) : base(message, inner) {}
}