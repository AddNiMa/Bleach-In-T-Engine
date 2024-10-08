using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 充值购买 message
 */
public class ReqRechargeMessage : Message 
{
	//商品Id
	int _commodityId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商品Id
		SerializeUtils.WriteInt(stream, _commodityId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商品Id
		_commodityId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商品Id
	 */
	public int CommodityId
	{
		set { _commodityId = value; }
	    get { return _commodityId; }
	}
	
	
	public override int GetId() 
	{
		return 312201;
	}
}