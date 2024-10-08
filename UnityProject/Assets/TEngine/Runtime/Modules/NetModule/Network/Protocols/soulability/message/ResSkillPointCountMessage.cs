using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 最新技能点数 message
 */
public class ResSkillPointCountMessage : Message 
{
	//最新技能点数
	int _skillPoint;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//最新技能点数
		SerializeUtils.WriteInt(stream, _skillPoint);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//最新技能点数
		_skillPoint = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 最新技能点数
	 */
	public int SkillPoint
	{
		set { _skillPoint = value; }
	    get { return _skillPoint; }
	}
	
	
	public override int GetId() 
	{
		return 304104;
	}
}