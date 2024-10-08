using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 成长卡信息
 */
public class GrowthCardInfo : IMessageSerialize 
{
	//商品Id
	int _commodityId;	
	//使用到的位置
	int _usedValue;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//商品Id
		SerializeUtils.WriteInt(stream, _commodityId);
		//使用到的位置
		SerializeUtils.WriteInt(stream, _usedValue);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//商品Id
		_commodityId = SerializeUtils.ReadInt(stream);
		//使用到的位置
		_usedValue = SerializeUtils.ReadInt(stream);
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
	 * 使用到的位置
	 */
	public int UsedValue
	{
		set { _usedValue = value; }
	    get { return _usedValue; }
	}
	
}