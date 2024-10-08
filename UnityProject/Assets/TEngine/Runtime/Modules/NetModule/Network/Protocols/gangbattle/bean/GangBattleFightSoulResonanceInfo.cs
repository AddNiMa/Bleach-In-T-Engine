using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战参战玩家魂共鸣信息
 */
public class GangBattleFightSoulResonanceInfo : IMessageSerialize 
{
	//魂共鸣id
	int _resonanceId;	
	//魂共鸣等级
	int _resonanceLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//魂共鸣id
		SerializeUtils.WriteInt(stream, _resonanceId);
		//魂共鸣等级
		SerializeUtils.WriteInt(stream, _resonanceLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//魂共鸣id
		_resonanceId = SerializeUtils.ReadInt(stream);
		//魂共鸣等级
		_resonanceLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 魂共鸣id
	 */
	public int ResonanceId
	{
		set { _resonanceId = value; }
	    get { return _resonanceId; }
	}
	
	/**
	 * 魂共鸣等级
	 */
	public int ResonanceLevel
	{
		set { _resonanceLevel = value; }
	    get { return _resonanceLevel; }
	}
	
}