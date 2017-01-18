namespace SabberStone.Loader
{
    internal struct PlayerReqDesc
    {
        public int ReqId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool AlwaysReq { get; set; }
        public bool HasParam { get; set; }
        public bool IsTargetDetail { get; set; }
    }
}