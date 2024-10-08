using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 极限挑战信息[单个] message
 */
public class ResUnlimitFightInfoMessage : Message 
{
	//单个极限挑战信息
	UnlimitFightBaseInfo _unlimitFightBaseInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//单个极限挑战信息
		SerializeUtils.WriteBean(stream, _unlimitFightBaseInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//单个极限挑战信息
		_unlimitFightBaseInfo = SerializeUtils.ReadBean<UnlimitFightBaseInfo>(stream);
	}
	
	/**
	 * 单个极限挑战信息
	 */
	public UnlimitFightBaseInfo UnlimitFightBaseInfo
	{
		set { _unlimitFightBaseInfo = value; }
	    get { return _unlimitFightBaseInfo; }
	}
	
	
	public override int GetId() 
	{
		return 221103;
	}
}