using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 限时挑战信息
 */
public class LimitTimeChallengeInfo : IMessageSerialize 
{
	//限时挑战编号
	int _limitTimeChallengeId;	
	//是否已经开启[1:已经开启,0:未开启]
	int _isOpen;	
	//挑战结束时间[毫秒值]
	long _endTime;	
	//进度值[分子]
	int _value;	
	//状态[0:未完成,1:已经完成,2:已经领奖]
	int _status;	
	//是否已经知晓超时[0:未知晓,1:已经知晓]
	int _isOverSee;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//限时挑战编号
		SerializeUtils.WriteInt(stream, _limitTimeChallengeId);
		//是否已经开启[1:已经开启,0:未开启]
		SerializeUtils.WriteInt(stream, _isOpen);
		//挑战结束时间[毫秒值]
		SerializeUtils.WriteLong(stream, _endTime);
		//进度值[分子]
		SerializeUtils.WriteInt(stream, _value);
		//状态[0:未完成,1:已经完成,2:已经领奖]
		SerializeUtils.WriteInt(stream, _status);
		//是否已经知晓超时[0:未知晓,1:已经知晓]
		SerializeUtils.WriteInt(stream, _isOverSee);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//限时挑战编号
		_limitTimeChallengeId = SerializeUtils.ReadInt(stream);
		//是否已经开启[1:已经开启,0:未开启]
		_isOpen = SerializeUtils.ReadInt(stream);
		//挑战结束时间[毫秒值]
		_endTime = SerializeUtils.ReadLong(stream);
		//进度值[分子]
		_value = SerializeUtils.ReadInt(stream);
		//状态[0:未完成,1:已经完成,2:已经领奖]
		_status = SerializeUtils.ReadInt(stream);
		//是否已经知晓超时[0:未知晓,1:已经知晓]
		_isOverSee = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 限时挑战编号
	 */
	public int LimitTimeChallengeId
	{
		set { _limitTimeChallengeId = value; }
	    get { return _limitTimeChallengeId; }
	}
	
	/**
	 * 是否已经开启[1:已经开启,0:未开启]
	 */
	public int IsOpen
	{
		set { _isOpen = value; }
	    get { return _isOpen; }
	}
	
	/**
	 * 挑战结束时间[毫秒值]
	 */
	public long EndTime
	{
		set { _endTime = value; }
	    get { return _endTime; }
	}
	
	/**
	 * 进度值[分子]
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	/**
	 * 状态[0:未完成,1:已经完成,2:已经领奖]
	 */
	public int Status
	{
		set { _status = value; }
	    get { return _status; }
	}
	
	/**
	 * 是否已经知晓超时[0:未知晓,1:已经知晓]
	 */
	public int IsOverSee
	{
		set { _isOverSee = value; }
	    get { return _isOverSee; }
	}
	
}