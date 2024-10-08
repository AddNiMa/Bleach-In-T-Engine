using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 竞技场排行榜
 */
public class ArenaRankingBean : IMessageSerialize
{
    //排名
    int _rank;
    //新排名
    int _newRank;
    //玩家名字
    string _playerName;
    //玩家等级
    int _playerLevel;
    //番队名字
    string _gangName;
    //vip等级
    int _vipLevel;
    //玩家id
    long _playerId;
    //出战角色
    List<ArenaFightCharacterInfo> _fightCharacterInfos = new List<ArenaFightCharacterInfo>();

    /**
     * 序列化
     */
    public void Serialize(Stream stream)
    {
        //排名
        SerializeUtils.WriteInt(stream, _rank);
        //新排名
        SerializeUtils.WriteInt(stream, _newRank);
        //玩家名字
        SerializeUtils.WriteString(stream, _playerName);
        //玩家等级
        SerializeUtils.WriteInt(stream, _playerLevel);
        //番队名字
        SerializeUtils.WriteString(stream, _gangName);
        //vip等级
        SerializeUtils.WriteInt(stream, _vipLevel);
        //玩家id
        SerializeUtils.WriteLong(stream, _playerId);
        //出战角色
        SerializeUtils.WriteShort(stream, (short)_fightCharacterInfos.Count);

        foreach (var element in _fightCharacterInfos)
        {
            SerializeUtils.WriteBean(stream, element);
        }
    }

    /**
     * 反序列化
     */
    public void Deserialize(Stream stream)
    {
        //排名
        _rank = SerializeUtils.ReadInt(stream);
        //新排名
        _newRank = SerializeUtils.ReadInt(stream);
        //玩家名字
        _playerName = SerializeUtils.ReadString(stream);
        //玩家等级
        _playerLevel = SerializeUtils.ReadInt(stream);
        //番队名字
        _gangName = SerializeUtils.ReadString(stream);
        //vip等级
        _vipLevel = SerializeUtils.ReadInt(stream);
        //玩家id
        _playerId = SerializeUtils.ReadLong(stream);
        //出战角色
        int _fightCharacterInfos_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _fightCharacterInfos_length; ++i)
        {
            _fightCharacterInfos.Add(SerializeUtils.ReadBean<ArenaFightCharacterInfo>(stream));
        }
    }

    /**
     * 排名
     */
    public int Rank
    {
        set { _rank = value; }
        get { return _rank; }
    }

    /**
     * 新排名
     */
    public int NewRank
    {
        set { _newRank = value; }
        get { return _newRank; }
    }

    /**
     * 玩家名字
     */
    public string PlayerName
    {
        set { _playerName = value; }
        get { return _playerName; }
    }

    /**
     * 玩家等级
     */
    public int PlayerLevel
    {
        set { _playerLevel = value; }
        get { return _playerLevel; }
    }

    /**
     * 番队名字
     */
    public string GangName
    {
        set { _gangName = value; }
        get { return _gangName; }
    }

    /**
     * vip等级
     */
    public int VipLevel
    {
        set { _vipLevel = value; }
        get { return _vipLevel; }
    }

    /**
     * 玩家id
     */
    public long PlayerId
    {
        set { _playerId = value; }
        get { return _playerId; }
    }

    /**
     * get 出战角色
     * @return 
     */
    public List<ArenaFightCharacterInfo> GetFightCharacterInfos()
    {
        return _fightCharacterInfos;
    }

    /**
     * set 出战角色
     */
    public void SetFightCharacterInfos(List<ArenaFightCharacterInfo> fightCharacterInfos)
    {
        _fightCharacterInfos = fightCharacterInfos;
    }

}