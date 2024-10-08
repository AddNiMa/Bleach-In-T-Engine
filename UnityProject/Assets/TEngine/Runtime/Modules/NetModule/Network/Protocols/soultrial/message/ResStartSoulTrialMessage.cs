using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 *  message
 */
public class ResStartSoulTrialMessage : Message 
{
	//0：成功 1：等级不够
	int _success;	
	//试炼id
	int _trialId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功 1：等级不够
		SerializeUtils.WriteInt(stream, _success);
		//试炼id
		SerializeUtils.WriteInt(stream, _trialId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功 1：等级不够
		_success = SerializeUtils.ReadInt(stream);
		//试炼id
		_trialId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功 1：等级不够
	 */
	public int Success
	{
		set { _success = value; }
	    get { return _success; }
	}
	
	/**
	 * 试炼id
	 */
	public int TrialId
	{
		set { _trialId = value; }
	    get { return _trialId; }
	}
	
	
	public override int GetId() 
	{
		return 204103;
	}
}