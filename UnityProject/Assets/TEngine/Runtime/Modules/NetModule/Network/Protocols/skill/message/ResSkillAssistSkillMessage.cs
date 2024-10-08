using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步援护技能 message
 */
public class ResSkillAssistSkillMessage : Message 
{
	//技能信息
	AssistSkillInfo _info;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//技能信息
		SerializeUtils.WriteBean(stream, _info);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//技能信息
		_info = SerializeUtils.ReadBean<AssistSkillInfo>(stream);
	}
	
	/**
	 * 技能信息
	 */
	public AssistSkillInfo Info
	{
		set { _info = value; }
	    get { return _info; }
	}
	
	
	public override int GetId() 
	{
		return 208102;
	}
}