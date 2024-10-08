using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 充值购买回复 message
 */
public class ResRechargeMessage : Message 
{
	//充值结果 0-成功 1-失败
	int _result;	
	//订单Id
	string _orderId;	
	//商品Id
	int _commodityId;	
	//购买次数
	int _buyTime;	
	//价格（RMB)
	int _price;	
	//数量
	int _count;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//充值结果 0-成功 1-失败
		SerializeUtils.WriteInt(stream, _result);
		//订单Id
		SerializeUtils.WriteString(stream, _orderId);
		//商品Id
		SerializeUtils.WriteInt(stream, _commodityId);
		//购买次数
		SerializeUtils.WriteInt(stream, _buyTime);
		//价格（RMB)
		SerializeUtils.WriteInt(stream, _price);
		//数量
		SerializeUtils.WriteInt(stream, _count);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//充值结果 0-成功 1-失败
		_result = SerializeUtils.ReadInt(stream);
		//订单Id
		_orderId = SerializeUtils.ReadString(stream);
		//商品Id
		_commodityId = SerializeUtils.ReadInt(stream);
		//购买次数
		_buyTime = SerializeUtils.ReadInt(stream);
		//价格（RMB)
		_price = SerializeUtils.ReadInt(stream);
		//数量
		_count = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 充值结果 0-成功 1-失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 订单Id
	 */
	public string OrderId
	{
		set { _orderId = value; }
	    get { return _orderId; }
	}
	
	/**
	 * 商品Id
	 */
	public int CommodityId
	{
		set { _commodityId = value; }
	    get { return _commodityId; }
	}
	
	/**
	 * 购买次数
	 */
	public int BuyTime
	{
		set { _buyTime = value; }
	    get { return _buyTime; }
	}
	
	/**
	 * 价格（RMB)
	 */
	public int Price
	{
		set { _price = value; }
	    get { return _price; }
	}
	
	/**
	 * 数量
	 */
	public int Count
	{
		set { _count = value; }
	    get { return _count; }
	}
	
	
	public override int GetId() 
	{
		return 312102;
	}
}