using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战信息
 */
public class GangBattleInfo : IMessageSerialize 
{
	//玩家报名标志，0：报名失败，1：报名成功
	int _playerApply;	
	//番队报名标志，0：报名失败，1：报名成功
	int _gangApply;	
	//0：非幸运番队，1：幸运番队
	int _isLucky;	
	//番队战积分
	int _gangBattleScore;	
	//番队战胜负，0：负，1：胜利，2：未出结果
	int _gangBattleResult;	
	//已参战次数
	int _fightTimes;	
	//胜利次数
	int _winTimes;	
	//出战角色id
	List<int> _fightCharacterIds = new List<int>();
	//使用的魂共鸣
	List<int> _soulResonanceIds = new List<int>();
    //书院等级
    int _collegeStage;
    //书院技能书编号
    List<int> _collegeBookIdList = new List<int>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家报名标志，0：报名失败，1：报名成功
		SerializeUtils.WriteInt(stream, _playerApply);
		//番队报名标志，0：报名失败，1：报名成功
		SerializeUtils.WriteInt(stream, _gangApply);
		//0：非幸运番队，1：幸运番队
		SerializeUtils.WriteInt(stream, _isLucky);
		//番队战积分
		SerializeUtils.WriteInt(stream, _gangBattleScore);
		//番队战胜负，0：负，1：胜利，2：未出结果
		SerializeUtils.WriteInt(stream, _gangBattleResult);
		//已参战次数
		SerializeUtils.WriteInt(stream, _fightTimes);
		//胜利次数
		SerializeUtils.WriteInt(stream, _winTimes);
		//出战角色id
		SerializeUtils.WriteShort(stream, (short)_fightCharacterIds.Count);

		foreach (var element in _fightCharacterIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//使用的魂共鸣
		SerializeUtils.WriteShort(stream, (short)_soulResonanceIds.Count);

		foreach (var element in _soulResonanceIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
        //书院等级
        SerializeUtils.WriteInt(stream, _collegeStage);
        //书院技能书编号
        SerializeUtils.WriteShort(stream, (short)_collegeBookIdList.Count);

        foreach (var element in _collegeBookIdList)
        {
            SerializeUtils.WriteInt(stream, element);
        }
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家报名标志，0：报名失败，1：报名成功
		_playerApply = SerializeUtils.ReadInt(stream);
		//番队报名标志，0：报名失败，1：报名成功
		_gangApply = SerializeUtils.ReadInt(stream);
		//0：非幸运番队，1：幸运番队
		_isLucky = SerializeUtils.ReadInt(stream);
		//番队战积分
		_gangBattleScore = SerializeUtils.ReadInt(stream);
		//番队战胜负，0：负，1：胜利，2：未出结果
		_gangBattleResult = SerializeUtils.ReadInt(stream);
		//已参战次数
		_fightTimes = SerializeUtils.ReadInt(stream);
		//胜利次数
		_winTimes = SerializeUtils.ReadInt(stream);
		//出战角色id
		int _fightCharacterIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fightCharacterIds_length; ++i) 
		{
			_fightCharacterIds.Add(SerializeUtils.ReadInt(stream));
		}
		//使用的魂共鸣
		int _soulResonanceIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _soulResonanceIds_length; ++i) 
		{
			_soulResonanceIds.Add(SerializeUtils.ReadInt(stream));
		}
        //书院等级
        _collegeStage = SerializeUtils.ReadInt(stream);
        //书院技能书编号
        int _collegeBookIdList_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _collegeBookIdList_length; ++i)
        {
            _collegeBookIdList.Add(SerializeUtils.ReadInt(stream));
        }
	}
	
	/**
	 * 玩家报名标志，0：报名失败，1：报名成功
	 */
	public int PlayerApply
	{
		set { _playerApply = value; }
	    get { return _playerApply; }
	}
	
	/**
	 * 番队报名标志，0：报名失败，1：报名成功
	 */
	public int GangApply
	{
		set { _gangApply = value; }
	    get { return _gangApply; }
	}
	
	/**
	 * 0：非幸运番队，1：幸运番队
	 */
	public int IsLucky
	{
		set { _isLucky = value; }
	    get { return _isLucky; }
	}
	
	/**
	 * 番队战积分
	 */
	public int GangBattleScore
	{
		set { _gangBattleScore = value; }
	    get { return _gangBattleScore; }
	}
	
	/**
	 * 番队战胜负，0：负，1：胜利，2：未出结果
	 */
	public int GangBattleResult
	{
		set { _gangBattleResult = value; }
	    get { return _gangBattleResult; }
	}
	
	/**
	 * 已参战次数
	 */
	public int FightTimes
	{
		set { _fightTimes = value; }
	    get { return _fightTimes; }
	}
	
	/**
	 * 胜利次数
	 */
	public int WinTimes
	{
		set { _winTimes = value; }
	    get { return _winTimes; }
	}
	
	/**
	 * get 出战角色id
	 * @return 
	 */
	public List<int> GetFightCharacterIds()
	{
		return _fightCharacterIds;
	}
	
	/**
	 * set 出战角色id
	 */
	public void SetFightCharacterIds(List<int> fightCharacterIds)
	{
		_fightCharacterIds = fightCharacterIds;
	}
	
	/**
	 * get 使用的魂共鸣
	 * @return 
	 */
	public List<int> GetSoulResonanceIds()
	{
		return _soulResonanceIds;
	}
	
	/**
	 * set 使用的魂共鸣
	 */
	public void SetSoulResonanceIds(List<int> soulResonanceIds)
	{
		_soulResonanceIds = soulResonanceIds;
	}
    /**
 * 书院等级
 */
    public int CollegeStage
    {
        set { _collegeStage = value; }
        get { return _collegeStage; }
    }

    /**
     * get 书院技能书编号
     * @return 
     */
    public List<int> GetCollegeBookIdList()
    {
        return _collegeBookIdList;
    }

    /**
     * set 书院技能书编号
     */
    public void SetCollegeBookIdList(List<int> collegeBookIdList)
    {
        _collegeBookIdList = collegeBookIdList;
    }
}