using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 开始灵魂试炼 message
 */
public class ReqStartSoulTrialMessage : Message 
{
	//试炼id
	int _trialId;	
	//出战角色id
	int _characterId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//试炼id
		SerializeUtils.WriteInt(stream, _trialId);
		//出战角色id
		SerializeUtils.WriteInt(stream, _characterId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//试炼id
		_trialId = SerializeUtils.ReadInt(stream);
		//出战角色id
		_characterId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 试炼id
	 */
	public int TrialId
	{
		set { _trialId = value; }
	    get { return _trialId; }
	}
	
	/**
	 * 出战角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	
	public override int GetId() 
	{
		return 204201;
	}
}