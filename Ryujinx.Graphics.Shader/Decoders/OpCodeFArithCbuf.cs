using Ryujinx.Graphics.Shader.Instructions;

namespace Ryujinx.Graphics.Shader.Decoders
{
    class OpCodeFArithCbuf : OpCodeFArith, IOpCodeCbuf
    {
        public int Offset { get; }
        public int Slot   { get; }

        public OpCodeFArithCbuf(InstEmitter emitter, ulong address, long opCode) : base(emitter, address, opCode)
        {
            Offset = opCode.Extract(20, 14);
            Slot   = opCode.Extract(34, 5);
        }
    }
}