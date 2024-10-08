using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求开始极限挑战扫荡 message
 */
public class ReqMopUnlimitFightBattleMessage : Message 
{
	//极限挑战编号
	int _unlimitId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//极限挑战编号
		SerializeUtils.WriteInt(stream, _unlimitId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//极限挑战编号
		_unlimitId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 极限挑战编号
	 */
	public int UnlimitId
	{
		set { _unlimitId = value; }
	    get { return _unlimitId; }
	}
	
	
	public override int GetId() 
	{
		return 221202;
	}
}