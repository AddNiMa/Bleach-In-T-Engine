using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 抽奖请求 message
 */
public class ReqStartLotteryMessage : Message
{
    //0：A消耗环单抽，1：A消耗环十连抽，2：B消耗魂玉单抽，3：B消耗魂玉十连抽，4：C消耗魂玉单抽
    int _type;
    //0：非免费 1：免费
    int _isFree;

    /**
     * 序列化
     */
    public override void Serialize(Stream stream)
    {
        //0：A消耗环单抽，1：A消耗环十连抽，2：B消耗魂玉单抽，3：B消耗魂玉十连抽，4：C消耗魂玉单抽
        SerializeUtils.WriteInt(stream, _type);
        //0：非免费 1：免费
        SerializeUtils.WriteInt(stream, _isFree);
    }

    /**
     * 反序列化
     */
    public override void Deserialize(Stream stream)
    {
        //0：A消耗环单抽，1：A消耗环十连抽，2：B消耗魂玉单抽，3：B消耗魂玉十连抽，4：C消耗魂玉单抽
        _type = SerializeUtils.ReadInt(stream);
        //0：非免费 1：免费
        _isFree = SerializeUtils.ReadInt(stream);
    }

    /**
     * 0：A消耗环单抽，1：A消耗环十连抽，2：B消耗魂玉单抽，3：B消耗魂玉十连抽，4：C消耗魂玉单抽
     */
    public int Type
    {
        set { _type = value; }
        get { return _type; }
    }

    /**
     * 0：非免费 1：免费
     */
    public int IsFree
    {
        set { _isFree = value; }
        get { return _isFree; }
    }


    public override int GetId()
    {
        return 212101;
    }
}