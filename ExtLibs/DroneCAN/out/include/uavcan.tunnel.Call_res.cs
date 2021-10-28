

using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DroneCAN
{
    public partial class DroneCAN {




        public const int UAVCAN_TUNNEL_CALL_RES_MAX_PACK_SIZE = 61;
        public const ulong UAVCAN_TUNNEL_CALL_RES_DT_SIG = 0xDB11EDC510502658;

        public const int UAVCAN_TUNNEL_CALL_RES_DT_ID = 63;






        public partial class uavcan_tunnel_Call_res: IDroneCANSerialize {



            public uint8_t buffer_len; [MarshalAs(UnmanagedType.ByValArray,SizeConst=60)] public uint8_t[] buffer = Enumerable.Range(1, 60).Select(i => new uint8_t()).ToArray();




            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx)
            {
                encode_uavcan_tunnel_Call_res(this, chunk_cb, ctx);
            }

            public void decode(CanardRxTransfer transfer)
            {
                decode_uavcan_tunnel_Call_res(transfer, this);
            }
        }
    }
}
