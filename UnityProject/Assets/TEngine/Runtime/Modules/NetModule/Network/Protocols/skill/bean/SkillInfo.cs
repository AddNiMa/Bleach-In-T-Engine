using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 技能信息
 */
public class SkillInfo : IMessageSerialize 
{
	//技能id
	int _skillId;	
	//技能强化系数
	int _enhance;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//技能id
		SerializeUtils.WriteInt(stream, _skillId);
		//技能强化系数
		SerializeUtils.WriteInt(stream, _enhance);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//技能id
		_skillId = SerializeUtils.ReadInt(stream);
		//技能强化系数
		_enhance = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 技能id
	 */
	public int SkillId
	{
		set { _skillId = value; }
	    get { return _skillId; }
	}
	
	/**
	 * 技能强化系数
	 */
	public int Enhance
	{
		set { _enhance = value; }
	    get { return _enhance; }
	}
	
}