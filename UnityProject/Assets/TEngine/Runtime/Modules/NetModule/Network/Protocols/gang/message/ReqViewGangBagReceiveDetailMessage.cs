using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求查看福袋领取明细 message
 */
public class ReqViewGangBagReceiveDetailMessage : Message 
{
	//福袋id
	long _bagId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//福袋id
		SerializeUtils.WriteLong(stream, _bagId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//福袋id
		_bagId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 福袋id
	 */
	public long BagId
	{
		set { _bagId = value; }
	    get { return _bagId; }
	}
	
	
	public override int GetId() 
	{
		return 109227;
	}
}