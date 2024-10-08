using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 完成灵魂试炼 message
 */
public class ReqCompleteSoulTrialMessage : Message 
{
	//是否通过
	int _isSuccess;	
	//试炼id
	int _trialId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//是否通过
		SerializeUtils.WriteInt(stream, _isSuccess);
		//试炼id
		SerializeUtils.WriteInt(stream, _trialId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//是否通过
		_isSuccess = SerializeUtils.ReadInt(stream);
		//试炼id
		_trialId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 是否通过
	 */
	public int IsSuccess
	{
		set { _isSuccess = value; }
	    get { return _isSuccess; }
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
		return 204202;
	}
}