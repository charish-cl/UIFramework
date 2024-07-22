namespace UIFramework {
    /// <summary>
    /// 枚举类型，用于定义窗口在打开时、在历史记录和队列中的行为
    /// </summary>
    public enum WindowPriority {
        //关闭其他所有的
        ForceForeground = 0,
        
        //老老实实放到队列里的
        Enqueue = 1,
    }
}
