using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 自己的地狱蝶信息
 */
public class ButterflyInfo : IMessageSerialize 
{
	//cd剩余秒数
	int _cdTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//cd剩余秒数
		SerializeUtils.WriteInt(stream, _cdTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//cd剩余秒数
		_cdTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * cd剩余秒数
	 */
	public int CdTime
	{
		set { _cdTime = value; }
	    get { return _cdTime; }
	}
	
}