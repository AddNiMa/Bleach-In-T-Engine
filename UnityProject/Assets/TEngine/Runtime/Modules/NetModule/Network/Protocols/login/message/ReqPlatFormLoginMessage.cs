using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 棱镜登陆 message
 */
public class ReqPlatFormLoginMessage : Message
{
    //用户id
    string _userId;
    //渠道编码
    string _channel;
    //登陆令牌
    string _token;
    //产品编码
    string _productCode;
    //渠道名称
    string _channelLable;
    //服务器Id
    int _serverId;
    //消息数量
    int _msgCount;
    //游戏版本号
    int _gameVersion;
    //手机硬件信息
    string _phoneInfo;
    //应用宝payToken
    string _payToken;
    //应用宝pf
    string _pf;
    //应用宝pfKey
    string _pfKey;
    //时间
    long _time;

    /**
     * 序列化
     */
    public override void Serialize(Stream stream)
    {
        //用户id
        SerializeUtils.WriteString(stream, _userId);
        //渠道编码
        SerializeUtils.WriteString(stream, _channel);
        //登陆令牌
        SerializeUtils.WriteString(stream, _token);
        //产品编码
        SerializeUtils.WriteString(stream, _productCode);
        //渠道名称
        SerializeUtils.WriteString(stream, _channelLable);
        //服务器Id
        SerializeUtils.WriteInt(stream, _serverId);
        //消息数量
        SerializeUtils.WriteInt(stream, _msgCount);
        //游戏版本号
        SerializeUtils.WriteInt(stream, _gameVersion);
        //手机硬件信息
        SerializeUtils.WriteString(stream, _phoneInfo);
        //应用宝payToken
        SerializeUtils.WriteString(stream, _payToken);
        //应用宝pf
        SerializeUtils.WriteString(stream, _pf);
        //应用宝pfKey
        SerializeUtils.WriteString(stream, _pfKey);
        //时间
        SerializeUtils.WriteLong(stream, _time);
    }

    /**
     * 反序列化
     */
    public override void Deserialize(Stream stream)
    {
        //用户id
        _userId = SerializeUtils.ReadString(stream);
        //渠道编码
        _channel = SerializeUtils.ReadString(stream);
        //登陆令牌
        _token = SerializeUtils.ReadString(stream);
        //产品编码
        _productCode = SerializeUtils.ReadString(stream);
        //渠道名称
        _channelLable = SerializeUtils.ReadString(stream);
        //服务器Id
        _serverId = SerializeUtils.ReadInt(stream);
        //消息数量
        _msgCount = SerializeUtils.ReadInt(stream);
        //游戏版本号
        _gameVersion = SerializeUtils.ReadInt(stream);
        //手机硬件信息
        _phoneInfo = SerializeUtils.ReadString(stream);
        //应用宝payToken
        _payToken = SerializeUtils.ReadString(stream);
        //应用宝pf
        _pf = SerializeUtils.ReadString(stream);
        //应用宝pfKey
        _pfKey = SerializeUtils.ReadString(stream);
        //时间
        _time = SerializeUtils.ReadLong(stream);
    }

    /**
     * 用户id
     */
    public string UserId
    {
        set { _userId = value; }
        get { return _userId; }
    }

    /**
     * 渠道编码
     */
    public string Channel
    {
        set { _channel = value; }
        get { return _channel; }
    }

    /**
     * 登陆令牌
     */
    public string Token
    {
        set { _token = value; }
        get { return _token; }
    }

    /**
     * 产品编码
     */
    public string ProductCode
    {
        set { _productCode = value; }
        get { return _productCode; }
    }

    /**
     * 渠道名称
     */
    public string ChannelLable
    {
        set { _channelLable = value; }
        get { return _channelLable; }
    }

    /**
     * 服务器Id
     */
    public int ServerId
    {
        set { _serverId = value; }
        get { return _serverId; }
    }

    /**
     * 消息数量
     */
    public int MsgCount
    {
        set { _msgCount = value; }
        get { return _msgCount; }
    }

    /**
     * 游戏版本号
     */
    public int GameVersion
    {
        set { _gameVersion = value; }
        get { return _gameVersion; }
    }

    /**
     * 手机硬件信息
     */
    public string PhoneInfo
    {
        set { _phoneInfo = value; }
        get { return _phoneInfo; }
    }

    /**
     * 应用宝payToken
     */
    public string PayToken
    {
        set { _payToken = value; }
        get { return _payToken; }
    }

    /**
     * 应用宝pf
     */
    public string Pf
    {
        set { _pf = value; }
        get { return _pf; }
    }

    /**
     * 应用宝pfKey
     */
    public string PfKey
    {
        set { _pfKey = value; }
        get { return _pfKey; }
    }

    /**
     * 时间
     */
    public long Time
    {
        set { _time = value; }
        get { return _time; }
    }


    public override int GetId()
    {
        return 100205;
    }
}