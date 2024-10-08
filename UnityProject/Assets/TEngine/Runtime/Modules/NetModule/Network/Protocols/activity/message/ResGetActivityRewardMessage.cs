using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动领奖 message
 */
public class ResGetActivityRewardMessage : Message 
{
	//1成功,0失败 
	int _type;	
	//活动
	ActivityTriggerBean _activity;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//1成功,0失败 
		SerializeUtils.WriteInt(stream, _type);
		//活动
		SerializeUtils.WriteBean(stream, _activity);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//1成功,0失败 
		_type = SerializeUtils.ReadInt(stream);
		//活动
		_activity = SerializeUtils.ReadBean<ActivityTriggerBean>(stream);
	}
	
	/**
	 * 1成功,0失败 
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 活动
	 */
	public ActivityTriggerBean Activity
	{
		set { _activity = value; }
	    get { return _activity; }
	}
	
	
	public override int GetId() 
	{
		return 311105;
	}
}