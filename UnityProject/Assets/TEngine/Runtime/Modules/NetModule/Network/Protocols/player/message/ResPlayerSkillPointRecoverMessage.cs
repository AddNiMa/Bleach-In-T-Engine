using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家技能点恢复 message
 */
public class ResPlayerSkillPointRecoverMessage : Message 
{
	//当前技能点数
	int _skillPoint;	
	//距离下次恢复的秒数
	int _cdTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前技能点数
		SerializeUtils.WriteInt(stream, _skillPoint);
		//距离下次恢复的秒数
		SerializeUtils.WriteInt(stream, _cdTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前技能点数
		_skillPoint = SerializeUtils.ReadInt(stream);
		//距离下次恢复的秒数
		_cdTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当前技能点数
	 */
	public int SkillPoint
	{
		set { _skillPoint = value; }
	    get { return _skillPoint; }
	}
	
	/**
	 * 距离下次恢复的秒数
	 */
	public int CdTime
	{
		set { _cdTime = value; }
	    get { return _cdTime; }
	}
	
	
	public override int GetId() 
	{
		return 105109;
	}
}