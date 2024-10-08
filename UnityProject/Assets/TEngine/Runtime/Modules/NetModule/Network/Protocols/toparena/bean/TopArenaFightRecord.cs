using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 巅峰竞技场对战记录
 */
public class TopArenaFightRecord : IMessageSerialize 
{
	//防守纪录id
	long _recordId;	
	//0：负，1：胜
	int _isWin;	
	//对战比分结果
	string _result;	
	//积分变化
	int _scoreChange;	
	//自己出战队伍
	TopArenaFightersInfo _myCharacter;	
	//对手出战队伍
	TopArenaFightersInfo _oppoCharacter;	
	//发生时间，0：一分钟内，其他：几分钟前
	int _fightTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//防守纪录id
		SerializeUtils.WriteLong(stream, _recordId);
		//0：负，1：胜
		SerializeUtils.WriteInt(stream, _isWin);
		//对战比分结果
		SerializeUtils.WriteString(stream, _result);
		//积分变化
		SerializeUtils.WriteInt(stream, _scoreChange);
		//自己出战队伍
		SerializeUtils.WriteBean(stream, _myCharacter);
		//对手出战队伍
		SerializeUtils.WriteBean(stream, _oppoCharacter);
		//发生时间，0：一分钟内，其他：几分钟前
		SerializeUtils.WriteInt(stream, _fightTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//防守纪录id
		_recordId = SerializeUtils.ReadLong(stream);
		//0：负，1：胜
		_isWin = SerializeUtils.ReadInt(stream);
		//对战比分结果
		_result = SerializeUtils.ReadString(stream);
		//积分变化
		_scoreChange = SerializeUtils.ReadInt(stream);
		//自己出战队伍
		_myCharacter = SerializeUtils.ReadBean<TopArenaFightersInfo>(stream);
		//对手出战队伍
		_oppoCharacter = SerializeUtils.ReadBean<TopArenaFightersInfo>(stream);
		//发生时间，0：一分钟内，其他：几分钟前
		_fightTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 防守纪录id
	 */
	public long RecordId
	{
		set { _recordId = value; }
	    get { return _recordId; }
	}
	
	/**
	 * 0：负，1：胜
	 */
	public int IsWin
	{
		set { _isWin = value; }
	    get { return _isWin; }
	}
	
	/**
	 * 对战比分结果
	 */
	public string Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 积分变化
	 */
	public int ScoreChange
	{
		set { _scoreChange = value; }
	    get { return _scoreChange; }
	}
	
	/**
	 * 自己出战队伍
	 */
	public TopArenaFightersInfo MyCharacter
	{
		set { _myCharacter = value; }
	    get { return _myCharacter; }
	}
	
	/**
	 * 对手出战队伍
	 */
	public TopArenaFightersInfo OppoCharacter
	{
		set { _oppoCharacter = value; }
	    get { return _oppoCharacter; }
	}
	
	/**
	 * 发生时间，0：一分钟内，其他：几分钟前
	 */
	public int FightTime
	{
		set { _fightTime = value; }
	    get { return _fightTime; }
	}
	
}