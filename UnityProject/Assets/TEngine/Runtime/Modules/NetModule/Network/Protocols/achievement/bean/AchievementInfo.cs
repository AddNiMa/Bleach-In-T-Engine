using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 成就信息
 */
public class AchievementInfo : IMessageSerialize 
{
	//成就Id
	int _achieveId;	
	//进度值
	int _value;	
	//状态，0-未完成，1-已完成，2-已领奖
	int _status;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//成就Id
		SerializeUtils.WriteInt(stream, _achieveId);
		//进度值
		SerializeUtils.WriteInt(stream, _value);
		//状态，0-未完成，1-已完成，2-已领奖
		SerializeUtils.WriteInt(stream, _status);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//成就Id
		_achieveId = SerializeUtils.ReadInt(stream);
		//进度值
		_value = SerializeUtils.ReadInt(stream);
		//状态，0-未完成，1-已完成，2-已领奖
		_status = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 成就Id
	 */
	public int AchieveId
	{
		set { _achieveId = value; }
	    get { return _achieveId; }
	}
	
	/**
	 * 进度值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	/**
	 * 状态，0-未完成，1-已完成，2-已领奖
	 */
	public int Status
	{
		set { _status = value; }
	    get { return _status; }
	}
	
}