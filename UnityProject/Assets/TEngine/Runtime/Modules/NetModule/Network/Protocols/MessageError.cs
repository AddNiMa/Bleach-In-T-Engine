public enum MessageError {
    // 未知错误
    UNKNOWN_ERROR = -1,

    // 登录读取帐号失败
    LOGIN_LOAD_USER_FAILED = 10001,

    // 帐号禁止登录
    LOGIN_USER_FORBID = 10002,

    // 登录玩家数量达到上限
    LOGIN_TOO_MANY_PLAYER = 10003,

    // 登录密钥验证失败
    LOGIN_VERIFY_FAILED = 10004,

    // 登录没有此Gm帐号
    LOGIN_NOTHAVE_GM = 10006,

    // 登录时，玩家正在退出中
    LOGIN_ON_PLAYER_QUITIING = 10007,

    // 加载角色失败
    LOGIN_LOAD_PLAYER_FAILED = 10100,

    // 角色帐号错误
    LOGIN_PLAYER_ACCOUNT_ERROR = 10101,

    // 创建角色过多
    CREATE_TOO_MANY_PLAYER = 10200,

    // 角色创建数据库错误
    CREATE_DATABASE_ERROR = 10201,

    // 玩家体力不足
    HEALTH_NOT_ENOUGH = 10202,

    // 扫荡次数错误
    CLEARANCE_NUM_NOT_CORRECT = 10203,

    // 等级不足
    GRADE_NOT_CORRECT = 10204,

    // 没有完成前一个关卡
    NOT_COMPLETE_PRE_LEVEL = 10205,

    // 扫荡不是vip1
    MOP_NOT_VIP_1 = 10206,

    // 扫荡不是vip4
    MOP_NOT_VIP_4 = 10207,

    // 关卡先易后难
    EASY_THINGS_FIRST = 10208,

    // 环数不足（金钱不足）
    GOLD_NOT_ENOUGH = 10209,

    // 活力值不足
    VITALITY_NOT_ENOUGH = 10210,

    // 魂玉不足 
    SOUL_NOT_ENOUGH = 10211,

    // 不是vip
    NOT_VIP = 10212,

    // 超过最大补满星星次数
    OVER_MAX_FILLUP_STARNUM = 10213,

    // 缺少角色
    MISSING_ROLE = 10214,

    // 角色虚弱
    ROLE_IS_WEAK = 10215,

    // 星星不足
    STAR_NOT_ENOUGH = 10216,

    // 探索id不正确
    DISCOVERY_NOT_CORRECT = 10221,

    // 探索角色数量不正确
    DISCOVERY_ROLE_NUM_NOT_CORRECT = 10222,

    // 探索角色已经使用过
    DISCOVERY_ROLE_HAS_USED = 10223,

    // 缺少用于探索的角色
    LACK_DISCOVERY_CHARACTERS = 10224,

    // 探索时长不够
    DISCOVERY_NOT_ENOUGH = 10225,

    // 玩家还没有开始探索
    NOT_BEGIN_DISCOVERY = 10226,

    // 角色不存在
    CHARACTER_NOT_EXIST = 10227,

    // 角色不含有该灵魂能力
    CHARACTER_NOT_CONTAIN_SOULABILITY = 10228,

    // 角色武器等级不够
    CHARACTER_WEAPONS_LEVEL_NOT_ENOUGH = 10229,

    // 玩家灵子不足
    PLAYER_SPIRIT_NOT_ENOUGH = 10230,

    // 灵魂能力还未激活
    SOULABILITY_NOT_ACTIVATE = 10231,

    // 灵魂能力重复激活
    SOULABILITY_REPEAT_ACTIVATE = 10232,

    // 今日已经签到
    TODAY_SIGNED = 10233,

    // 超过最大可补签次数
    OVER_MAX_CAN_PATCH_SIGNNUM = 10234,

    // 关卡不存在
    LEVEL_NOT_EXIST = 10235,

    // 关卡还未通关
    LEVEL_HAS_NOT_CLEARANCE = 10236,

    // 10连扫，星星不足
    CLEARANCE_STAR_NUM_NOT_ENOUGH = 10237,

    // 玩家等级不够
    PLAYER_LEVEL_NOT_ENOUGH = 10238,

    // 玩家扫荡卷和魂玉不足
    PLAYER_MOPTICKET_AND_SOUL_NOT_ENOUGH = 10239,

    // 温泉id不正确
    SPRINGID_NOT_CORRECT = 10240,

    // 温泉招待券不足
    SPRING_FETE_TICKET_NOT_ENOUGH = 10241,

    // 玩家已下线或者玩家不存在
    PLAYER_OFFLINE_OR_NOT_EXIST = 10242,

    // 玩家发送IM消息类型不正确
    IM_TYPE_NOT_CORRECT = 10243,

    // 玩家发送IM消息内容不能为空
    IM_CONTENT_NOT_NULL = 10244,

    // 玩家发送IM消息间隔时间不够
    IM_SPOKESMAN_INTERVAL_NOT_ENOUGH = 10245,

    // 玩家发送IM消息长度过大
    IM_LENG_TOO_LARGE = 10246,

    // 玩家的地址在禁言ip黑名单
    PLAYER_IN_SILENCE_IP_BLACKLIS = 10247,

    // 玩家在禁言玩家黑名单
    PLAYER_IN_SILENCE_PLAYER_BLACKLIST = 10248,

    // 玩家的地址在封号ip黑名单
    PLAYER_IN_FREEZE_IP_BLACKLIST = 10249,

    // 玩家在封号玩家黑名单
    PLAYER_IN_FREEZE_PLAYER_BLACKLIST = 10250,

    // 探索角色重复
    DISCOVERY_ROLE_REPEAT = 10251,

    // 玩家被顶号
    PLAYER_REPLACED = 10252,
    
    // 出售道具过于平凡
    ITEM_SELL_CD = 10253,

    // 出售道具不存在
    ITEM_SELL_NULL = 10254,

    // 出售道具 客户端单价配置与服务器不同
    ITEM_SELL_ERROR = 10255,

    // 出售道具 数量大于拥有数量
    ITEM_SELL_MAX_NUM = 10256,

    // 出售道具 拥有金钱大于最大值
    ITEM_SELL_MAX_GOLD = 10257,
    // 不能出售
    ITEM_NOT_SELL = 101208,
}