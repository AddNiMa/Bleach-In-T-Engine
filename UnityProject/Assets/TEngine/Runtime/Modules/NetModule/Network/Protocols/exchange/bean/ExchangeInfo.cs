using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 魂玉兑换信息
 */
public class ExchangeInfo : IMessageSerialize 
{
	//环已兑换次数
	int _goldTimes;	
	//环可兑换次数
	int _goldTotalTimes;	
	//体力已兑换次数
	int _healthTimes;	
	//体力可兑换次数
	int _healthTotalTimes;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//环已兑换次数
		SerializeUtils.WriteInt(stream, _goldTimes);
		//环可兑换次数
		SerializeUtils.WriteInt(stream, _goldTotalTimes);
		//体力已兑换次数
		SerializeUtils.WriteInt(stream, _healthTimes);
		//体力可兑换次数
		SerializeUtils.WriteInt(stream, _healthTotalTimes);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//环已兑换次数
		_goldTimes = SerializeUtils.ReadInt(stream);
		//环可兑换次数
		_goldTotalTimes = SerializeUtils.ReadInt(stream);
		//体力已兑换次数
		_healthTimes = SerializeUtils.ReadInt(stream);
		//体力可兑换次数
		_healthTotalTimes = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 环已兑换次数
	 */
	public int GoldTimes
	{
		set { _goldTimes = value; }
	    get { return _goldTimes; }
	}
	
	/**
	 * 环可兑换次数
	 */
	public int GoldTotalTimes
	{
		set { _goldTotalTimes = value; }
	    get { return _goldTotalTimes; }
	}
	
	/**
	 * 体力已兑换次数
	 */
	public int HealthTimes
	{
		set { _healthTimes = value; }
	    get { return _healthTimes; }
	}
	
	/**
	 * 体力可兑换次数
	 */
	public int HealthTotalTimes
	{
		set { _healthTotalTimes = value; }
	    get { return _healthTotalTimes; }
	}
	
}