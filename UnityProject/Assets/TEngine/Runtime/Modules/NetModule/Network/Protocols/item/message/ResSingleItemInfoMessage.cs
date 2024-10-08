using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步玩家单个物品信息 message
 */
public class ResSingleItemInfoMessage : Message 
{
	//物品信息
	ItemInfo _itemInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//物品信息
		SerializeUtils.WriteBean(stream, _itemInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//物品信息
		_itemInfo = SerializeUtils.ReadBean<ItemInfo>(stream);
	}
	
	/**
	 * 物品信息
	 */
	public ItemInfo ItemInfo
	{
		set { _itemInfo = value; }
	    get { return _itemInfo; }
	}
	
	
	public override int GetId() 
	{
        return 101104;
	}
}